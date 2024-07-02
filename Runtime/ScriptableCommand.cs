using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Nonatomic.ScriptableCommands
{
	/// <summary>
	/// Base class for all scriptable object commands.
	/// </summary>
	public abstract class ScriptableCommand : ScriptableObject, IScriptableCommand
	{
		public abstract Task ExecuteAsync(CancellationToken cancellationToken = default);
	}
}