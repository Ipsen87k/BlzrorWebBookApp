namespace BlzrorWebBookApp.Data
{
	public interface IObserver<in T>
    {
        Task Update(T observable,int times=1);
    }
}
