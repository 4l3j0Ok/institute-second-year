import { useEffect, useState } from "react";
import { Icon } from "@iconify/react";
import type { Car } from "../types/car";
import "./Contact.css";


const STORAGE_KEY = "contact_car";

export default function Contact() {
    const [attachedCar, setAttachedCar] = useState<Car | null>(null);
    const [isRemoving, setIsRemoving] = useState(false);

    useEffect(() => {
        // Función para cargar el carro desde localStorage
        const loadCarFromStorage = () => {
            const stored = localStorage.getItem(STORAGE_KEY);
            if (stored) {
                try {
                    const storedCar = JSON.parse(stored);
                    setAttachedCar(storedCar);
                    setIsRemoving(false);
                } catch (e) {
                    console.error("Error parsing stored car:", e);
                    localStorage.removeItem(STORAGE_KEY);
                }
            }
        };

        // Escuchar cambios en el storage
        const handleStorageChange = () => {
            loadCarFromStorage();
        };
        window.addEventListener("storage", handleStorageChange);

        loadCarFromStorage();

        // Limpiar el listener al desmontar para evitar fugas de memoria
        return () => {
            window.removeEventListener("storage", handleStorageChange);
        };
    }, []);

    const handleRemoveCar = () => {
        setIsRemoving(true);
        // Esperar a que termine la animación antes de remover
        setTimeout(() => {
            setAttachedCar(null);
            localStorage.removeItem(STORAGE_KEY);
            setIsRemoving(false);
        }, 300); // Duración de la animación bounceOut
    };

    return (
        <section className="contact" id="contact">
            <h2>Contacto</h2>
            <form className="contact-form" id="contact-form">
                {attachedCar && (
                    <div
                        className={`car-attachment${isRemoving ? ' removing' : ''}`}
                        id="car-attachment"
                    >
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
