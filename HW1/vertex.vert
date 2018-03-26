#version 330 core

layout (location = 0) in vec3 position;
uniform mat4 rotate;
out vec3 loc;
void main()
{
    //gl_Position = vec4(position.x*cos(time), position.y, position.z*sin(time), 1.0f);
	gl_Position=rotate*vec4(position,1.0f);
	loc=position;
}