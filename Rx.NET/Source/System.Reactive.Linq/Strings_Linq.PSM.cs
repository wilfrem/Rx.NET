using System;

namespace System.Reactive
{
#if PSM
	public static class Strings_Linq
	{
		public static string CANT_ADVANCE_WHILE_RUNNING	="{0} cannot be called when the scheduler is already running. Try using Sleep instead.	";
		public static string COULD_NOT_FIND_INSTANCE_EVENT	="Could not find event '{0}' on object of type '{1}'.	";
		public static string COULD_NOT_FIND_STATIC_EVENT	="Could not find event '{0}' on type '{1}'.	";
		public static string EVENT_ADD_METHOD_SHOULD_TAKE_ONE_PARAMETER	="Add method should take 1 parameter.	";
		public static string EVENT_ARGS_NOT_ASSIGNABLE	="The second parameter of the event delegate must be assignable to '{0}'.	";
		public static string EVENT_MISSING_ADD_METHOD	="Event is missing the add method.	";
		public static string EVENT_MISSING_REMOVE_METHOD	="Event is missing the remove method.	";
		public static string EVENT_MUST_RETURN_VOID	="The event delegate must have a void return type.	";
		public static string EVENT_PATTERN_REQUIRES_TWO_PARAMETERS	="The event delegate must have exactly two parameters.	";
		public static string EVENT_REMOVE_METHOD_SHOULD_TAKE_ONE_PARAMETER	="Remove method should take 1 parameter.	";
		public static string EVENT_SENDER_NOT_ASSIGNABLE	="The first parameter of the event delegate must be assignable to '{0}'.	";
		public static string EVENT_WINRT_REMOVE_METHOD_SHOULD_TAKE_ERT	="Remove method of a WinRT event should take an EventRegistrationToken.	Only onn platforms supporting WinRT.";
		public static string MORE_THAN_ONE_ELEMENT	="Sequence contains more than one element.	";
		public static string MORE_THAN_ONE_MATCHING_ELEMENT	="Sequence contains more than one matching element.	";
		public static string NO_ELEMENTS	="Sequence contains no elements.	";
		public static string NO_MATCHING_ELEMENTS	="Sequence contains no matching element.	";

	}
#endif
}

