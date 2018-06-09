using Solution.Model.Models;

namespace Solution.Application.Applications
{
	public interface IAuthenticationApplication : IBaseApplication
	{
		AuthenticatedModel Authenticate(AuthenticationModel authentication);

		void Logout(long userId);
	}
}
