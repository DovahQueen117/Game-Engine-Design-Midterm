#pragma once

#include "CheckpointTimeLogger.h"

#ifdef __cplusplus
extern "C"
{
#endif

	PLUGIN_API void ResetLogger();

	//Save most recent checkpoint time
	PLUGIN_API void SaveCheckpointTime(float RTBC);

	//Gets total time for race
	PLUGIN_API float GetTotalTime();

	//Get checkpoint time at index
	PLUGIN_API float GetCheckpointTime(int index);

	//Get number of checkpoints saved
	PLUGIN_API int GetNumCheckpoint();

#ifdef __cplusplus
}
#endif