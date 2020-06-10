using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.Animations;
using TheSecondTrial.Animation;

namespace Tests
{
    public class AnimationOrchestratorTestSuite
    {
        private const float timeEnd = 2f;

        private AnimatorController controller;
        private GameObject gameObject;
        private AnimationOrcherstrator orchestrator;

        private bool flag;

        [SetUp]
        public void SetUp()
        {
            var animationClip = CreateAnimationClip();
            this.controller = CreateController(animationClip);

            this.gameObject = new GameObject("object");
            this.gameObject.transform.position = new Vector3(0, 0, 0);
            var animator = this.gameObject.AddComponent<Animator>();
            animator.runtimeAnimatorController = this.controller;
            animator.applyRootMotion = true;

            this.orchestrator = new AnimationOrcherstrator(animationClip, this.gameObject);
            this.orchestrator.AddEvent(timeEnd, () => { this.flag = true; });
            this.flag = false;
        }

        [TearDown]
        public void TearDown()
        {
            UnityEngine.Object.Destroy(this.gameObject);
            UnityEngine.Object.Destroy(this.controller);

            this.orchestrator.Dispose();
        }

        // A Test behaves as an ordinary method
        [Test]
        public void DummyTest()
        {
            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator AnimationOrchestratorSuccessfullyAddsEvent()
        {
            Assert.IsFalse(this.flag, "Flag should be false");

            yield return new WaitForSeconds(timeEnd + 1f);

            Assert.IsTrue(this.flag, "Flag should have been changed by the added event");
        }

        private static AnimationClip CreateAnimationClip()
        {
            var eventTime = timeEnd;
            var translateX = AnimationCurve.Linear(0, 0, eventTime, 20);
            var animationClip = new AnimationClip();

            // Add animation
            animationClip.SetCurve("", typeof(Transform), "localPosition.x", translateX);

            return animationClip;
        }

        private static AnimatorController CreateController(Motion motion)
        {
            var controller = new AnimatorController();
            controller.AddLayer("root");
            var rootStateMachine = controller.layers[0].stateMachine;
            var state = rootStateMachine.AddState("Animate");
            state.motion = motion;

            return controller;
        }
    }
}
