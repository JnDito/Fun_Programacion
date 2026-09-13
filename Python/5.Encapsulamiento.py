# Restringir Acceso a Campos o Valores

class CuentaAhorro:
    def __init__(self, titular, SaldoIncial):
        self.titular = titular  # Campo Público
        self.__saldo = SaldoIncial  # Campo Restringido

    def depositar(self, monto):
        if monto > 0:
            self.__saldo += monto  # Nuevo saldo Restringido
            print(f"Depósito exitoso: {monto}. Nuevo saldo: {self.__saldo}")
        else:
            print("Monto inválido para depósito.")

    def mostrar_saldo(self):
        print(f"Titular: {self.titular}")
        print(f"Saldo: {self.__saldo:.2F}")  # Restringido

cuenta = CuentaAhorro("Juan Vasquez", 1500)  # Declarar funcion class cuentaAhorro
cuenta.depositar(500)
cuenta.mostrar_saldo()