from fastapi import FastAPI, Depends, Query, HTTPException
from typing import Annotated
from models import db
from sqlmodel import select
from sqlalchemy import func
from sqlalchemy.exc import IntegrityError
from models.car import Car, CarCreate, CarResponse
import uvicorn


app = FastAPI()


@app.get("/cars", response_model=CarResponse)
def get_cars(
    session: Annotated[db.Session, Depends(db.get_session)],
    car_code: Annotated[
        str | None, Query(description="Filtrar por código del vehículo")
    ] = None,
    brand: Annotated[str | None, Query(description="Filtrar por marca")] = None,
    model: Annotated[str | None, Query(description="Filtrar por modelo")] = None,
    year: Annotated[int | None, Query(description="Filtrar por año")] = None,
    offset: int = Query(0, ge=0, description="Número de registros a saltar"),
    limit: int = Query(
        100, ge=1, le=1000, description="Número máximo de registros a devolver"
    ),
):
    query = select(Car)
    if car_code:
        query = query.where(Car.car_code == car_code)
    if brand:
        query = query.where(Car.brand.contains(brand))
    if model:
        query = query.where(Car.model.contains(model))
    if year:
        query = query.where(Car.year == year)
    cars = session.exec(query.offset(offset).limit(limit)).all()
    total_query = select(func.count()).select_from(Car)
    if brand:
        total_query = total_query.where(Car.brand.contains(brand))
    if model:
        total_query = total_query.where(Car.model.contains(model))
    if year:
        total_query = total_query.where(Car.year == year)
    total = session.exec(total_query).one()
    return CarResponse(total=total, offset=offset, limit=limit, items=cars)


@app.post("/cars", response_model=CarResponse)
def create_car(car: CarCreate, session: Annotated[db.Session, Depends(db.get_session)]):
    try:
        db_car = Car.model_validate(car)
        session.add(db_car)
        session.commit()
        session.refresh(db_car)
        return CarResponse(total=1, offset=0, limit=1, items=[db_car])
    except IntegrityError as ie:
        session.rollback()
        if car.car_code and "car.car_code" in str(ie.orig):
            raise HTTPException(
                status_code=409,
                detail=f"El código del vehículo '{car.car_code}' ya existe.",
            )
        raise HTTPException(
            status_code=400,
            detail=f"Los datos del auto son inválidos o incompletos: {ie.orig.args[0]}",
        )


if __name__ == "__main__":
    db.create_db_and_tables()
    uvicorn.run("main:app", host="0.0.0.0", port=8000, reload=True)
