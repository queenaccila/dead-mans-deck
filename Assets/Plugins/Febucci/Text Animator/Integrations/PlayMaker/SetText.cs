using Febucci.UI.Core;
using HutongGames.PlayMaker;

namespace Febucci.UI.PlayMaker
{
    [ActionCategory("TextAnimator")]
    [HutongGames.PlayMaker.Tooltip("Sets a text via TextAnimator")]
    public class SetText : FsmStateAction
    {
        [UIHint(UIHint.TextArea)]
        public FsmString textToShow;

        [RequiredField, UIHint(UIHint.ScriptComponent)]
        public TypewriterCore typewriter;

        public override void OnEnter()
        {
            base.OnEnter();
            typewriter.ShowText(textToShow.Value);
            typewriter.onTextShowed.AddListener(Finish);
        }

        public override void OnExit()
        {
            base.OnExit();
            typewriter.onTextShowed.RemoveListener(Finish);
            typewriter.StopShowingText();
        }
    }

}
