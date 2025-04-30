import { cars } from "../catalog.js";


function displayCar() {
    const container = document.querySelector(".car");
    container.innerHTML = "";
    const fileName = window.location.pathname.split('/').pop();
    const carId = fileName.replace('.html', '');
    cars.forEach(car => {
        if (car.id != carId) { return; }
        const div = document.createElement("div")
        let price = `<b>Precio</b>: ${car.price}`;
        if (car.promotionPrice !== undefined) {
            price = `<b>Precio</b>: <span style="color:red;"><s>$${car.price}</s></span> $${car.promotionPrice}`;
        }
        div.innerHTML = `
            <section class="car-info">
            <div class="car-image">
                <img src="${car.img}" alt="Ford Ka">
            </div>
            <div class="car-actions">
                <h1>${car.brand} ${car.model}</h1>
                <p>Precio: ${price}</p>
            </div>
        </section>
        <section class="car-details">
            <h2>Detalles del auto</h2>
            <p>Descripción: ${car.description}</p>
            <p>Kilometraje: ${car.km}</p>
        </section>
        `;
        container.appendChild(div);
    })
}

displayCar();