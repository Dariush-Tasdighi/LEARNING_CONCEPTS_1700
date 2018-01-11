namespace LEARNING_CONCEPTS
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			// Solution (1)
			try
			{
				// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			}
			catch
			{
				System.Windows.Forms.MessageBox
					.Show("کاربر گرامی، خطای ناشناخته‌ای رخ داده است، خودت یه فکری به حالت خودت بکن");
			}
			// /Solution (1)

			// Solution (2)
			//try
			//{
			//	// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			//}
			//catch (System.Exception e)
			//{
			//	System.Windows.Forms.MessageBox.Show(e.Message);
			//}
			// /Solution (2)

			// Solution (3)
			try
			{
				// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			// /Solution (3)

			// Solution (4)
			try
			{
				// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			}
			catch (System.Exception ex)
			{
				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			// /Solution (4)

			// Solution (5)
			try
			{
				// Return
				// Throw

				// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			}
			catch (System.Exception ex)
			{
				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			finally
			{
			}
			// /Solution (5)

			// Solution (6)
			try
			{
				// Return
				// Throw

				// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			}
			catch (System.IO.IOException ex)
			{
				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			finally
			{
			}
			// /Solution (6)

			// Solution (7)
			//try
			//{
			//	// Return
			//	// Throw

			//// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			//}
			//catch (System.Exception ex)
			//{
			//	// Return
			//	// Throw

			//	// Log -> ex, ex.Message, ...
			//	System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			//}
			//catch (System.IO.IOException ex)
			//{
			//	// Return
			//	// Throw

			//	// Log -> ex, ex.Message, ...
			//	System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			//}
			//finally
			//{
			//}
			// /Solution (7)

			// Solution (8)
			try
			{
				// Return
				// Throw

				// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			}
			catch (System.IO.IOException ex)
			{
				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			catch (System.Exception ex)
			{
				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			finally
			{
			}
			// /Solution (8)

			// Solution (9)
			try
			{
				// Return
				// Throw

				// دستور یا دستوراتی که احساس می‌کنید احتمال بروز خطا دارند
			}
			catch (System.IO.IOException ex)
			{
				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			catch (System.DivideByZeroException ex)
			{
				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			catch (System.Data.SqlClient.SqlException ex)
			{
				//ex.Number
				//ex.Errors

				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			catch (System.Exception ex)
			{
				// Return
				// Throw

				// Log -> ex, ex.Message, ...
				System.Windows.Forms.MessageBox.Show("نمایش پیغام مناسب به زبان فارسی");
			}
			finally
			{
			}
			// /Solution (9)

			// Sample:

			System.IO.StreamReader streamReader = null;

			try
			{
				streamReader =
					new System.IO.StreamReader
					(path: "C:\\Readme.txt", encoding: System.Text.Encoding.UTF8);

				// کار می‌کنیم streamReader با
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
				if (streamReader != null)
				{
					streamReader.Dispose();
					streamReader = null;
				}
			}
		}
	}
}
