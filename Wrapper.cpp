#include "Wrapper.h"

CheckpointTimeLogger timelogger;

PLUGIN_API void ResetLogger()
{
	return timelogger.ResetLogger();
}

PLUGIN_API void SaveCheckpointTime(float RTBC)
{
	return timelogger.SaveCheckpointTime(RTBC);
}

PLUGIN_API float GetTotalTime()
{
	return timelogger.GetTotalTime();
}

PLUGIN_API float GetCheckpointTime(int index)
{
	return timelogger.GetCheckpointTime(index);
}

PLUGIN_API int GetNumCheckpoint()
{
	return timelogger.GetNumCheckpoints();
}
