using DoubTech.CastleDefender.AI.Interfaces.Troops;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace DoubTech.CastleDefender.AI.Nodes.Actions.Troops{

	[Category("Castle Defender/Troops/Movement")]
	[Description("Sets the troop target position instantly. This means units will indipendently move to their position without trying to maintain the formation.")]
	public class SetTroopPosition : ActionTask<ITroop>
	{
		public BBParameter<Vector3> position;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute()
		{
			agent.TroopPosition = position.value;
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate(){
			
		}

		//Called when the task is disabled.
		protected override void OnStop(){
			
		}

		//Called when the task is paused.
		protected override void OnPause(){
			
		}
	}
}