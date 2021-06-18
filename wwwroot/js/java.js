const tarjeta = document.querySelector('#tarjeta'),
 formulario = document.querySelector('#formulario-tarjeta'),  
 numeroTarjeta = document.querySelector('#tarjeta .numero'),
	  nombreTarjeta = document.querySelector('#tarjeta .nombre'),  
 mesExpiracion = document.querySelector('#tarjeta .mes'),
 yearExpiracion = document.querySelector('#tarjeta .year');
 ccv = document.querySelector('#tarjeta .ccv');
//cargar numeros a los selectores//
for(let i = 1; i <= 12; i++){
	let opcion = document.createElement('option');
	opcion.value= i ;
	opcion.innerText=i;
	formulario.selectMes.appendChild(opcion);
	
}
const yearActual = new Date().getFullYear();
for(let i = yearActual; i <= yearActual + 8; i++){
	let opcion = document.createElement('option');
	opcion.value = i;
	opcion.innerText = i;
	formulario.selectYear.appendChild(opcion);
}
//// agregar datos a la tarjeta
formulario.inputNumero.addEventListener('keyup', (e) => {
	let valorInput = e.target.value;

	formulario.inputNumero.value = valorInput
	// Eliminamos espacios en blanco
	.replace(/\s/g, '')
	// Eliminar las letras
	.replace(/\D/g, '')
	// Ponemos espacio cada cuatro numeros
	.replace(/([0-9]{4})/g, '$1 ')
	// Elimina el ultimo espaciado
	.trim();

	numeroTarjeta.textContent = valorInput;

});

formulario.inputNombre.addEventListener('keyup', (e) => {
	let valorInput = e.target.value;

	formulario.inputNombre.value = valorInput.replace(/[0-9]/g, '');
	nombreTarjeta.textContent = valorInput;

	if(valorInput == ''){
		nombreTarjeta.textContent = 'Monogaming Store';
	}

});

formulario.selectMes.addEventListener('change', (e) => {
	mesExpiracion.textContent = e.target.value;
	mostrarFrente();
});

formulario.selectYear.addEventListener('change', (e) => {
	yearExpiracion.textContent = e.target.value.slice(2);
	mostrarFrente();
});

