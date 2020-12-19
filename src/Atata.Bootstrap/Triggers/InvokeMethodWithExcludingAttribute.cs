using System.Linq;

namespace Atata.Bootstrap
{
    public class InvokeMethodWithExcludingAttribute : InvokeMethodAttribute
    {
        public InvokeMethodWithExcludingAttribute(string methodName, TriggerEvents on, TriggerPriority priority = TriggerPriority.Medium)
            : base(methodName, on, priority)
        {
        }

        /// <summary>
        /// Gets or sets the target component names to exclude.
        /// </summary>
        public string[] TargetNamesExclude { get; set; }

        /// <summary>
        /// Gets or sets the target component name to exclude.
        /// </summary>
        public string TargetNameExclude
        {
            get => TargetNamesExclude?.FirstOrDefault();
            set => TargetNamesExclude = value == null ? null : new[] { value };
        }

        protected override void Execute<TOwner>(TriggerContext<TOwner> context)
        {
            if (TargetNamesExclude == null || !TargetNamesExclude.Contains(context.Component.Metadata.Name))
            {
                base.Execute(context);
            }
            else
            {
                context.Log.Trace($"Skip trigger execution for {context.Component.ComponentFullName}");
            }
        }
    }
}
