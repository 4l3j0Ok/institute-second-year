from fastapi import FastAPI, Depends, Query
from typing import Annotated, Optional
from sqlmodel import Field, Session, SQLModel, create_engine, select
import uvicorn


app = FastAPI()


class Car(SQLModel, table=True):
    __tablename__ = "car"
    __table_args__ = {"extend_existing": True}
    id: Optional[int] = Field(default=None, primary_key=True)
    car_code: str = Field(
        default="",
        index=True,
        description="Unique code for the car, used for identification",
    )
    brand: str = Field(index=True)
    model: str = Field(index=True)
    description: str = Field(
        default="",
        description="HTML content describing the car, can include paragraphs and other HTML elements.",
    )
    price: float = Field(gt=0, description="Price of the car in currency units")
    promotion_price: float | None = Field(
        default=None, description="Promotional price if available"
    )
    km: int = Field(gt=0, description="Kilometers driven by the car")
    year: int = Field(gt=1900, le=2100, description="Year of manufacture")
    img: str = Field(
        default="",
        description="Path to the image of the car, can be a URL or local path",
    )


sqlite_file_name = "database.db"
sqlite_url = f"sqlite:///{sqlite_file_name}"

connect_args = {"check_same_thread": False}
engine = create_engine(sqlite_url, connect_args=connect_args)


def create_db_and_tables():
    # Drop existing tables to ensure the database schema matches the current models.
    # WARNING: This will erase existing data — use only in development or when you
    # intentionally want to reset the database.
    SQLModel.metadata.drop_all(engine)
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
