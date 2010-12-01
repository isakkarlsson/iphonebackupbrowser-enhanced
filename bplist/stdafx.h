// stdafx.h�: fichier Include pour les fichiers Include syst�me standard,
// ou les fichiers Include sp�cifiques aux projets qui sont utilis�s fr�quemment,
// et sont rarement modifi�s
//

#pragma once

#ifndef _WIN32_WINNT		// Autorise l'utilisation des fonctionnalit�s sp�cifiques � Windows�XP ou version ult�rieure.                   
#define _WIN32_WINNT 0x0600	// Attribuez la valeur appropri�e � cet �l�ment pour cibler d'autres versions de Windows.
#endif						

#include <windows.h>
#include <tchar.h>

#include <shlobj.h>
#include <objbase.h>

#if _WIN32_WINNT < 0x0600
#include "c:/Microsoft IDN Mitigation APIs/Include/normalization.h"
#endif


#include <stdio.h>

#include <io.h>

#include <cstring>
#include <cassert>
#include <ctime>

#include <algorithm>
#include <memory>
#include <vector>
#include <string>
#include <map>
#include <list>
#include <iostream>
#include <sstream>
#include <fstream>
