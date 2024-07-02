using System.Threading;
using System.Threading.Tasks;

namespace Nonatomic.ScriptableCommands
{
	public interface IScriptableCommand
	{
		Task ExecuteAsync(CancellationToken cancellationToken = default);
	}
}