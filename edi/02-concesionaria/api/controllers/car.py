from models.car import Car, CarCreate
from sqlmodel import select, Session
from typing import List, Optional
from fastapi import Depends, HTTPException, Query, UploadFile
import requests
import base64


class CarController:
    @staticmethod
    def _convert_image_to_base64(car: Car) -> Car:
        """Convierte la imagen de bytes a base64 para la respuesta"""
        if car.image and isinstance(car.image, bytes):
            car.image = base64.b64encode(car.image).decode("utf-8")
        return car

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
        # Convertir bytes a base64 en todas las imágenes
        cars_serialized = [CarController._convert_image_to_base64(car) for car in cars]
        return cars_serialized

    @staticmethod
    def create_car(session: Session, car: CarCreate) -> Car:
        existing_car = session.exec(
            select(Car).where(Car.car_code == car.car_code)
        ).first()
        if existing_car:
            raise HTTPException(
                status_code=409,
                detail=f"El código del vehículo '{car.car_code}' ya existe.",
            )
        if car.image:
            response = requests.get(car.image)
            if response.status_code == 200:
                content_type = response.headers.get("Content-Type", "")
                if content_type.startswith("image/"):
                    car.image = response.content
                else:
                    raise HTTPException(
                        status_code=400,
                        detail="La URL proporcionada no contiene una imagen válida.",
                    )
        car = Car(**car.model_dump())
        session.add(car)
        session.commit()
        session.refresh(car)
        # Convertir bytes a base64 antes de devolver
        return CarController._convert_image_to_base64(car)

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
        # Convertir bytes a base64 antes de devolver
        return CarController._convert_image_to_base64(car)

    @staticmethod
    def delete_car(session: Session, car_id: int) -> None:
        car = session.get(Car, car_id)
        if not car:
            raise HTTPException(status_code=404, detail="Car not found")
        session.delete(car)
        session.commit()
