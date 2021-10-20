﻿ using System;

namespace VacancyTask
{
    //для фигур неправильной формы ( параллелограммов, ромбов и т.п.) условие вычисления их площади по сторонам неприменимо, так как нужно знать хотя бы один угол, чтобы правильно представить форму. 
    //Для фигур, у которых углов больше четырех, углы могут оказаться больше 180 градусов (получится "вогнутая" фигура), что опять же, не отразить сторонами, 
    //поэтому единственные две фигуры, которые можно вычислить имея только стороны - это треугольник и прямоугольник(квадрат)
    //т.е. смысла делать удобным добавление новых фигур в такой код просто нет
    public abstract class Figure
    {
        public abstract int CalculateSquarespace();

    }
}