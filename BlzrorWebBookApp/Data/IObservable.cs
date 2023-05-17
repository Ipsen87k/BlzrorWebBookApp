namespace BlzrorWebBookApp.Data
{
	public interface IObservable
	{
		Task NotifyObserver(int times=1);
	}
}
