public class HaloGeneric {
    public void SapaUser<T>(T user){
        Console.WriteLine("Halo User " + user);
    }
}

public class DataGeneric<T>{
    private T data;

    public DataGeneric(T data){
        this.data = data;
    }

    public void PrintData(){
        Console.WriteLine("Data is " + data);
    }
}