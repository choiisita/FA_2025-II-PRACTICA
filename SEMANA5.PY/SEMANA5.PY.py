def ejer1():
edad = int(input("Ingrese su edad: "))

if edad >= 18:
    print("Puede votar.")

    if edad >=25:
        print("Candidato paras un cargo politico")

    else: 
        print("No es candidato para un cargo politico")

else:
    print("No puede votar.")
    print("No puede ejercer un cargo politico.")

ejer1()

def ejer2():
    lado1 = int(input("Ingrese lado1: "))
    lado2 = int(input("Ingrese lado2: "))
    lado3 = int(input("Ingrese lado3: "))

    if(lado1 == lado 2 == lado 3):
        print("EQUILATERO")
    elif lado1 == lado2 or lado1 == lado3 or lado2 == lado3:
        print("ISOSCELES")
    else:
        print("ESCALENO")

def ejer3():
    n=int(input("Ingrese el numero: "))

    print()

    for i in range(1,n+1):
        print(i)

        if i%2 == 0:
            suma += i 

    print("\nSuma de pares: ", suma)



    def ejer4(): 
    
    cant = int(input("Ingrese la cantidad de numeros: "))

    for i in range(1, cant + 1):
        num = int(input(f"Ingrese el numero {i}: "))

        if num ==0:
            ceros+=1
        elif num % 2==0:
            pares += 1 
        else:
            impares += 1

    print("\n#ceros: ", ceros)
    print("#pares: ", pares)
    print("#impares: ", impares)
