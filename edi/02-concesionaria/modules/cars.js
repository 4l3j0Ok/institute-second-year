import { cars } from "./catalog.js";


function displayCar() {
    const container = document.querySelector(".car");
    const fileName = window.location.pathname.split('/').pop();
    const carId = fileName.replace('.html', '');
    cars.forEach(car => {
        if (car.id != carId) { return; }
        let price = `<b>Precio</b>: ${car.price}`;
        if (car.promotionPrice !== undefined) {
            price = `<b>Precio</b>: <span style="color:red;"><s>$${car.price}</s></span> $${car.promotionPrice}`;
        }
        container.innerHTML = `
        <section class="car-presentation">
            <img src="${car.img.replace('./assets', '../assets')}" alt="Ford Ka">
        </section>
        <section class="car-details">
            <h2>Detalles del auto</h2>
            <div class="car-actions">
                <h1>${car.brand} ${car.model}</h1>
                <p>${price}</p>
            </div>
            <p>Descripción: ${car.description}</p>
            <p>Kilometraje: ${car.km}</p>
        </section>
        `;
        container.appendChild(div);
    })
}

displayCar();