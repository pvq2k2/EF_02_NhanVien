using EF_02_NhanVien.Services;
using EF_02_NhanVien.View;

internal class Program
{
    private static void Main(string[] args)
    {
        NhanVienView view = new NhanVienView();
        view.Menu();
    }
}