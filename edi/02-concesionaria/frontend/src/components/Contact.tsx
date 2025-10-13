import { useEffect, useState } from "react";
import { Icon } from "@iconify/react";
import type { Car } from "../types/car";
import "./Contact.css";

interface ContactProps {
    car?: Car;
}

const STORAGE_KEY = "contact_car";

export default function Contact({ car: initialCar }: ContactProps) {
    const [attachedCar, setAttachedCar] = useState<Car | null>(null);

    useEffect(() => {
        // Si hay un car pasado como prop, usarlo y guardarlo
        if (initialCar) {
            setAttachedCar(initialCar);
            localStorage.setItem(STORAGE_KEY, JSON.stringify(initialCar));
        } else {
            // Si no, intentar cargar desde localStorage
            const stored = localStorage.getItem(STORAGE_KEY);
            if (stored) {
                try {
                    const storedCar = JSON.parse(stored);
                    setAttachedCar(storedCar);
                } catch (e) {
                    console.error("Error parsing stored car:", e);
                    localStorage.removeItem(STORAGE_KEY);
                }
            }
        }
    }, [initialCar]);

    const handleRemoveCar = () => {
        setAttachedCar(null);
        localStorage.removeItem(STORAGE_KEY);
    };

    return (
        <section className="contact" id="contact">
            <h2>Contacto</h2>
            <form className="contact-form" id="contact-form">
                {attachedCar && (
                    <div className="car-attachment" id="car-attachment">
                        <div className="attachment-header">
                            <div className="attachment-info">
                                <Icon icon="mdi:information" />
                                <span>Consulta sobre este vehículo:</span>
                            </div>
                            <button
                                type="button"
                                className="remove-attachment"
                                onClick={handleRemoveCar}
                                aria-label="Quitar vehículo de la consulta"
                            >
                                <Icon icon="mdi:close" />
                            </button>
                        </div>
                        <a href={`/cars/${attachedCar.code}`} className="attachment-link">
                            <div className="car-tag">
                                {attachedCar.img && (
                                    <img
                                        src={attachedCar.img}
                                        alt={`${attachedCar.brand} ${attachedCar.model}`}
                                        className="car-tag-image"
                                    />
                                )}
                                <div className="car-tag-info">
                                    <strong>
                                        {attachedCar.brand} {attachedCar.model}
                                    </strong>
                                    <span className="car-tag-details">
                                        {attachedCar.year} •{" "}
                                        {attachedCar.km.toLocaleString()} km
                                    </span>
                                </div>
                            </div>
                        </a>
                        <input
                            type="hidden"
                            name="car_code"
                            value={attachedCar.code}
                        />
                    </div>
                )}
                <label htmlFor="name">Nombre y apellido:</label>
                <input
                    type="text"
                    name="name"
                    placeholder="Juan Pérez"
                    required
                    id="name"
                />
                <label htmlFor="message">Mensaje:</label>
                <textarea
                    name="message"
                    placeholder="Hola, quisiera contactarme por..."
                    required
                    id="message"
                />
                <button type="submit">Enviar</button>
            </form>
        </section >
    );
}
