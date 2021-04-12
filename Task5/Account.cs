namespace Task5
{
	internal class Account
	{
		/// <summary>
		/// Идентификатор аккаунта
		/// </summary>
		public int AccountId { get; set; }
		/// <summary>
		/// Почта
		/// </summary>
		public string Email { get; set; }
		/// <summary>
		/// Полное имя
		/// </summary>
		public string FullName { get; set; }
		/// <summary>
		/// Дата последнего входа
		/// </summary>
		public System.DateTime DateLastEnter { get; set; }

		public override string ToString() => $"Id: {AccountId}\nEmail: {Email}\nName: {FullName}\nDate Last Enter: {DateLastEnter}";
	}
}