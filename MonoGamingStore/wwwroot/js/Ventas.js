//cambias el precio en base a la cantidad
function multiplicador1()
{
 let selector = document.getElementById('selector-1');
 let numero = selector.value;
 document.getElementById('precio-1').innerText =`s/.${numero}00.00 .`;
 document.getElementById('Pfinal-1').innerText =`s/.${numero}60.00 (incluye IGV).`;
}

function multiplicador2()
{
 let selector = document.getElementById('selector-2');
 let numero = selector.value;
 document.getElementById('precio-2').innerText =`s/.${numero}00.00 .`;
 document.getElementById('Pfinal-2').innerText =`s/.${numero}60.00 (incluye IGV).`;
}

function multiplicador3()
{
 let selector = document.getElementById('selector-3');
 let numero = selector.value;
 document.getElementById('precio-3').innerText =`s/.${numero}00.00 .`;
 document.getElementById('Pfinal-3').innerText =`s/.${numero}60.00 (incluye IGV).`;
}
