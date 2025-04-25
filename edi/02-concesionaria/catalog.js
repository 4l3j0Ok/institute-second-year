export const cars = [
    {
        brand: "Fiat",
        model: "Uno",
        price: 10000000,
        promotionPrice: 9000000,
        km: 20,
        year: 2020,
        img: "./assets/images/fiat-uno.webp"
    },
    {
        brand: "Ford",
        model: "Ka",
        price: 15000000,
        promotionPrice: 14000000,
        km: 0,
        year: 2020,
        img: "./assets/images/ford-ka.webp"
    },
    {
        brand: "Chevrolet",
        model: "Onix",
        price: 20000000,
        promotionPrice: 19000000,
        km: 0,
        year: 2020,
        img: "./assets/images/chevrolet-onix.webp"
    }
];

function displayCars() {
    const container = document.querySelector(".catalog");
    container.innerHTML = "";
    cars.forEach(car => {
        const div = document.createElement("div");
        let price = `<b>Precio</b>: ${car.price}`;
        let endpoint = `./${car.brand.toLowerCase()}-${car.model.toLowerCase()}.html`;
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