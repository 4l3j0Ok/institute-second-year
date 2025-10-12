from pydantic import AnyUrl, BaseModel, computed_field
from typing import Optional, List, Union
from sqlmodel import SQLModel, Field, UniqueConstraint


# Base con validaciones
class CarBase(SQLModel):
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
    image: Optional[Union[AnyUrl, bytes]] = Field(
        default=None, description="URL de la imagen del vehículo"
    )


# Modelo de creación (input del POST)
class CarCreate(CarBase):
    @computed_field
    @property
    def car_code(self) -> str:
        return f"{self.brand.lower()}-{self.model.lower()}"


class CarRead(CarBase):
    id: int
    car_code: str
    image: Optional[str] = Field(
        default=None, description="Imagen del vehículo en formato base64"
    )


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
    car_code: str = Field(
        min_length=1, max_length=50, description="Código único del vehículo"
    )
    image: Optional[bytes] = Field(
        default=None, description="Imagen del vehículo en formato binario"
    )
    id: Optional[int] = Field(default=None, primary_key=True)
