#pragma once

#include "SteamclientAPI.h"

namespace dotnetworks
{
	public ref class AppID
	{ 
	public:
		AppID(AppId_t appId)
		{
			base = appId;
		}

	internal:
		AppId_t base;
	};
}