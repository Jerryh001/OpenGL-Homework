#include "stdafx.h"
#include "Camara.h"


Camara::Camara()
{
}

void Camara::Pos(const vec3 & p)
{
	pos = p;
	change = true;
}

void Camara::LookAt(const vec3 & l)
{
	lookat = l;
	change = true;
}

void Camara::Up(const vec3 & u)
{
	up = u;
	change = true;
}

mat4 Camara::View()
{
	if (change)
	{
		view = glm::lookAt(pos, lookat, up);
	}
	return view;
}

Camara& Camara::Instance()
{
	static Camara* instence;
	if (instence == nullptr)
	{
		instence = new Camara();
	}
	return *instence;
}

Camara::~Camara()
{
}
