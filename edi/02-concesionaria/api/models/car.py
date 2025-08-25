from pydantic import BaseModel
from typing import Optional, List
from sqlmodel import SQLModel, Field, UniqueConstraint


# Base con validaciones
class CarBase(SQLModel):
    car_code: str = Field(
        min_length=1, max_length=50, description="Código único del vehículo"
    )
    brand: str = Field(min_length=1, max_length=50, description="Marca del vehículo")
    model: str = Field(min_length=1, max_length=50, description="Modelo del vehículo")
    description: str = Field(
        min_length=1, description="Descripción detallada del vehículo"
    )
    price: float = Field(gt=0, description="Precio base del vehículo")
    promotion_price: Optional[float] = Field(
        default=None, gt=0, description="Precio promocional si está disponible"
    )
    km: int = Field(ge=0, description="Kilómetros recorridos del vehículo")
    year: int = Field(ge=1886, le=2100, description="Año de fabricación")
    img: str = Field(min_length=1, description="URL o ruta de la imagen del vehículo")


# Modelo de creación (input del POST)
class CarCreate(CarBase):
    pass


# Modelo de respuesta (output)
class CarRead(CarBase):
    id: int

    model_config = {"from_attributes": True}


class CarResponse(BaseModel):
    total: int
    offset: int
    limit: int
    items: List[CarRead]  # ahora usamos CarRead con from_attributes


# Modelo de tabla (DB)
class Car(CarBase, table=True):
    __tablename__ = "car"
    __table_args__ = (
        UniqueConstraint("car_code", name="uq_car_code"),
        {"extend_existing": True},
    )
    id: Optional[int] = Field(default=None, primary_key=True)
