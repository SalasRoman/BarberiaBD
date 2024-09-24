//funcion para redirigir a la pagina de inicio del administrador
function openAdminLogin(){
    window.location.href= "admin-login.html";
}

//Funcion para redirigir a la pagina de registro
function openRegistration(){
    window.Location.href= "registro.html";

}

//funcion para manejar el registro
function handleRegister(event){
    event.preventDefault(); // Prevenir el comportamiento predeterminado del formulcario

    // Aqui se puede agregar logica para guardar el registro en la base de datos 

    // Redirigir a la pagina de inicio de sesion despues de crear la cuenta 

    window.location.href= "login.html";

}

//Funcion para manejar el inicio de sesion 
function handleLogin(event){
    event.preventDefault(); //Prevenir el comportamiento prederteminado del formulario 

    //Aqui puedes agregar logica para validar las credenciales
    window.location.href= "citas.html"; // Redirigir a la pagina de citas 
}

//Funcion para manejar la cita 
function handleAppointment(event){
    event.preventDefault(); // Prevenir el comportamiento predeterminado del formulario

    // Aqui puedes agregar logica para procesar la cita guardar la base de datos 

    //Redirigir a la pagina de confirmacion 
    window.location.href= "agradecimiento.html"; // asegurate de que este archivo exista

}

//Validacion del formulario de inicio de sesion del administrador 
document.getElementById("adminLoginForm").addEventListener("submit", function(event) {
    event.preventDefault(); // Prevenir el comportamiento predeterminado del formulario

    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;

//Aqui puedes agregar una validacion simple o una logica para validar las credenciales
if (email === "admin@example.com" && password === "admin123"){
    //Redirigir a la pagina de citas si las credenciales son correctas
    window.location.href = "admin-citas.html";

} else {
    alert("Credenciales incorrectas. Por favor intenta nuevamente");

 }
});