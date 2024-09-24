public class Titular
{
    private string nombre;
    private string identificacion;
    private DateTime fechaNacimiento;

    public Titular(string nombre, string identificacion, DateTime fechaNacimiento)
    {
        this.nombre = nombre;
        this.identificacion = identificacion;
        this.fechaNacimiento = fechaNacimiento;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public string GetIdentificacion()
    {
        return identificacion;
    }

    public DateTime GetFechaNacimiento()
    {
        return fechaNacimiento;
    }

    public override string ToString()
    {
        return $"Nombre: {nombre}, Identificación: {identificacion}, Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}";
    }
}
