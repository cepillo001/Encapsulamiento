using Encapsulamiento.Modelo;

Console.WriteLine("Estamos creando un nuevo auto, ingrese el tipo de motor: ");
var tipoMotor = Console.ReadLine();

var miAuto = new Auto();

miAuto.TipoDeMotor = tipoMotor; // es el valor que toma la palabra reservada VALUE en TipoDeMotor, y se guarda en el Campo privado _tipoDeMotor

Console.WriteLine(miAuto.TipoDeMotor); // es ejecutado por el metodo GET de la propiedad TipoDeMotor


