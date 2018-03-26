#version 330 core

out vec4 color;
in vec3 loc;
void main()
{
	float ab=abs(loc.z*3)+0.2f;
    color = vec4(ab,ab,ab+0.2, 1.0f);
}