import { cars } from "./cars.js";

function displayCars() {
    const container = document.querySelector(".catalog");
    container.innerHTML = "";
    cars.forEach(car => {
        const div = document.createElement("div");
        let price = `<b>Precio</b>: ${car.price}`;
        let endpoint = `/${car.brand.toLowerCase()}-${car.model.toLowerCase()}.html`;
        if (car.promotionPrice !== undefined) {
            price = `<b>Precio</b>: <span style="color:red;"><s>$${car.price}</s></span> $${car.promotionPrice}`;
        }
        div.innerHTML = `
            <a href="${endpoint}" class="car-link">
                <div class="car" id="${car.brand}-${car.model}">
                    <img src="${car.img}" alt="${car.brand} ${car.model}">
                    <h2>${car.brand} ${car.model}</h2>
                    <p class="price">${price}</p>
                </div>
            </a>
        `;
        container.appendChild(div);
    });
}

displayCars();