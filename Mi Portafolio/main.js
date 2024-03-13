
document.addEventListener('DOMContentLoaded', function() {
    document.getElementById('contacto').addEventListener('submit', function(event) {
        var nombre = document.getElementById('nombre').value.trim();
        var email = document.getElementById('email').value.trim();
        var mensaje = document.getElementById('mensaje').value.trim();

        if (nombre === '' || email === '' || mensaje === '') {
            alert('Por favor, complete todos los campos del formulario.');
            event.preventDefault(); // Evita que el formulario se envíe
        } else {
            alert('Mensaje enviado:\n\nNombre: ' + nombre + '\nCorreo Electrónico: ' + email + '\nMensaje: ' + mensaje);
        }
    });

    







});