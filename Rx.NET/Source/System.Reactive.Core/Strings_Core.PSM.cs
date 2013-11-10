using System;

namespace System.Reactive
{
#if PSM
	public static class Strings_Core
	{
		public const string COMPLETED_NO_VALUE="OnCompleted notification doesn't have a value.";
		public const string CANT_OBTAIN_SCHEDULER="Using the Scheduler.{0} property is no longer supported due to refactoring of the API surface and elimination of platform-specific dependencies. Please include System.Reactive.PlatformServices for your target platform and use the {0}Scheduler type instead. If you're building a Windows Store app, notice some schedulers are no longer supported. Consider using Scheduler.Default instead.";
		public const string DISPOSABLE_ALREADY_ASSIGNED="Disposable has already been assigned.";
		public const string FAILED_CLOCK_MONITORING="Failed to start monitoring system clock changes.";
		public const string HEAP_EMPTY="Heap is empty.";
		public const string OBSERVER_TERMINATED="Observer has already terminated.";
		public const string REENTRANCY_DETECTED="Reentrancy has been detected.";
	}
#endif
}

