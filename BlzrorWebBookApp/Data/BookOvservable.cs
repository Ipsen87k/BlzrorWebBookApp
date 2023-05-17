namespace BlzrorWebBookApp.Data
{
	public class BookOvservable : IObservable
	{
		UserInputData UserInputData;
		IObserver<UserInputData> observer = new GetData();
		public BookOvservable(UserInputData userInputData)
		{
			UserInputData = userInputData;
		}
		public void NotifyObserver()
		{

		}
		public async Task NotifyObserver(int times = 1)
		{
			await observer.Update(UserInputData,times);
		}
	}
}
