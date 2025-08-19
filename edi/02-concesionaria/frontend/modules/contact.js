export function handleClick(event) {
    event.preventDefault();
    const name = document.querySelector("#name").value;
    const message = document.querySelector("#message").value;
    const subject = "contacto@premiumquality.com";
    const mailtoLink = `mailto:${subject}?subject=Consulta de ${name}&body=${message}`;
    window.open(mailtoLink, "_self");
}