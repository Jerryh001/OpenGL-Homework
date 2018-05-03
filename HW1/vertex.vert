#version 330 core

layout (location = 0) in vec3 position;
uniform mat4 rotate;
out vec3 loc;
void main()
{
	gl_Position=rotate*vec4(position,1.0f);
	loc=position;
}