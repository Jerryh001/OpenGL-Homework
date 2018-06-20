#version 330 core

out vec4 color_out;
uniform vec3 color;
void main()
{
    color_out = vec4(color,1.0f);
}