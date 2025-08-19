from fastapi import FastAPI, Depends, Query
from typing import Annotated
from pydantic import BaseModel
from sqlmodel import Field, Session, SQLModel, create_engine, select
import uvicorn


app = FastAPI()


class Car(SQLModel, table=True):
    __tablename__ = "car"
    __table_args__ = {"extend_existing": True}
    id: int = Field(default=None, primary_key=True)


sqlite_file_name = "database.db"
sqlite_url = f"sqlite:///{sqlite_file_name}"

connect_args = {"check_same_thread": False}
engine = create_engine(sqlite_url, connect_args=connect_args)


def create_db_and_tables():
    SQLModel.metadata.create_all(engine)


def get_session():
    with Session(engine) as session:
        yield session


SessionDep = Annotated[Session, Depends(get_session)]


@app.get("/cars")
def get_cars(
    session: SessionDep,
    offset: int = 0,
    limit: Annotated[int, Query(le=100)] = 100,
):
    return session.exec(select(Car).offset(offset).limit(limit)).all()


@app.post("/cars", response_model=Car)
def create_car(car: Car, session: SessionDep):
    session.add(car)
    session.commit()
    session.refresh(car)
    return car


if __name__ == "__main__":
    create_db_and_tables()
    uvicorn.run("main:app", host="0.0.0.0", port=8000)
