export function handleClick(event) {
    event.preventDefault(); // esto previene el comportamiento por defecto del formulario
    const name = document.querySelector("#name").value;
    const message = document.querySelector("#message").value;
    const subject = "contacto@premiumquality.com";
    const mailtoLink = `mailto:${subject}?subject=Consulta de ${name}&body=${message}`;
    window.location.href = mailtoLink;
    window.open(mailtoLink, "_self");
}