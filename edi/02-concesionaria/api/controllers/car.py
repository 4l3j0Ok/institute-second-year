from models.car import Car
from sqlmodel import select, Session
from typing import List, Optional
from fastapi import Depends, HTTPException, Query
# Hacemos la clase sea


class CarController:
    @staticmethod
    def get_cars(
        session: Session,
        car_code: Optional[str] = None,
        brand: Optional[str] = None,
        model: Optional[str] = None,
        year: Optional[int] = None,
        offset: int = 0,
        limit: int = 100,
    ) -> List[Car]:
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
        return cars

    @staticmethod
    def create_car(session: Session, car: Car) -> Car:
        existing_car = session.exec(
            select(Car).where(Car.car_code == car.car_code)
        ).first()
        if existing_car:
            raise HTTPException(
                status_code=409,
                detail=f"El código del vehículo '{car.car_code}' ya existe.",
            )
        session.add(car)
        session.commit()
        session.refresh(car)
        return car

    @staticmethod
    def update_car(session: Session, car_id: int, car_data: Car) -> Car:
        car = session.get(Car, car_id)
        if not car:
            raise HTTPException(status_code=404, detail="Car not found")
        for key, value in car_data.model_dump(exclude_unset=True).items():
            setattr(car, key, value)
        session.add(car)
        session.commit()
        session.refresh(car)
        return car

    @staticmethod
    def delete_car(session: Session, car_id: int) -> None:
        car = session.get(Car, car_id)
        if not car:
            raise HTTPException(status_code=404, detail="Car not found")
        session.delete(car)
        session.commit()
