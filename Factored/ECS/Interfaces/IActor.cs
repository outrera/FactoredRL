﻿using Factored.Actions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factored.ECS.Interfaces
{
	public interface IActor
	{
		IAction GetAction();
		void SetAction( IAction action );
	}
}
