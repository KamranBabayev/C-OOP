

namespace SmartDoor.Models;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 3.
        //SmartDoor adlı class yazın. Bu class bir ağıllı qapını təmsil edir və qapı yalnız düzgün şərtlər altında açılıb - bağlana bilər.
        //Tələblər:
        //Field-lər(private):
        //_isLocked — qapının kilidli olub-olmaması(bool)
        //_isOpen — qapının açıq olub-olmaması(bool)
        //_password — qapını açmaq üçün şifrə(string)

        //Property-lər:
        //-Password:
        //Şifrə ən azı 4 simvol olmalıdır.
        //Əgər 4-dən azdırsa, “Password too short!” mesajı çıxarılsın.
        //Dəyişdirilməyə icazə verilsin (yəni set işləsin).

        //Metodlar:
        //LockDoor() — qapını kilidləyir(_isLocked = true, _isOpen = false), mesaj: "Door locked"
        //UnlockDoor(string password) — qapını açmağa cəhd edir: Əgər daxil edilən şifrə Password ilə eynidirsə → qapı açılır(_isLocked = false) və mesaj: Door unlocked.Əks halda: Incorrect password.
        //OpenDoor() — yalnız qapı kilidli açıla bilər.Əgər kilidlidirsə: “Door is locked!” Əks halda: isOpen = true, mesaj: “Door is open”
        //CloseDoor() — qapını bağlayır, mesaj: “Door closed.”
        //ShowStatus() — qapının vəziyyətini ekrana çıxarır: (Door status: Locked, Is open: No)

        SmartDoor door = new SmartDoor();

        door.Password = "1253";

        door.UnlockDoor("1234"); 
        door.ShowStatus();

        door.UnlockDoor("1253"); //wrong  password
        door.OpenDoor();
        door.ShowStatus();

        door.CloseDoor();
        door.LockDoor();
        door.ShowStatus();

    }
}