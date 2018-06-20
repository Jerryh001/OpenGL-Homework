#pragma once
class Camara
{
	vec3 pos;
	vec3 lookat;
	vec3 up;
	mat4 view;
	Camara();
	bool change = true;
public:
	void Pos(const vec3& p);
	void LookAt(const vec3& l);
	void Up(const vec3& u);
	mat4 View();
	static Camara& Instance();
	~Camara();
};

