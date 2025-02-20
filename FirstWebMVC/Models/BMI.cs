namespace FirstWebMVC.Models;
public class BMIModel
{
    public double Height { get; set; } // Chiều cao tính bằng mét
    public double Weight { get; set; } // Cân nặng tính bằng kg

    public double CalculateBMI()
    {
        return Weight / (Height * Height);
    }
}
