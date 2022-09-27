let numeroDeAlunos = 10

for (let contador = 0; contador <= numeroDeAlunos; contador ++)
{
    if (contador == 0){
        console.log('O número atual é zero')
    }
    else if(contador % 2 == 0){
        console.log('O número ' + contador + ' é par')
    }
    else
        console.log(`O número ${contador} é impar`)
}