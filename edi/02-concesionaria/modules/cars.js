import { cars } from "./catalog.js";


export function displayCar() {
    const container = document.querySelector(".car");
    const fileName = window.location.pathname.split('/').pop();
    const carId = fileName.replace('.html', '');
    cars.forEach(car => {
        if (car.id != carId) { return; }
        let price = `<span>${car.price}</span>`;
        if (car.promotionPrice !== undefined) {
            price = `<span class="old-price">
                        <s>$${car.price}</s>
                    </span>
                    <br>
                    <b><span class="price">
                        $${car.promotionPrice}
                    </span></b>`;
        }
        container.innerHTML = `
        <section class="car-header">
            <section class="car-presentation">
                <img src="${car.img.replace('./assets', '../assets')}" alt="Ford Ka">
            </section>
            <section class="car-info">
                <h1>${car.brand} ${car.model}</h1>
                <p><b>${car.km}km</b></p>
                <p>${price}</p>
                </section>
        </section>
        <section class="car-description">
            <p>${car.description}</p>
        </section>
        `;
    })
}
