#pragma once

#include <QObject>
#include <qlabel.h>
#include <QGridLayout>
#include <opencv2/opencv.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/core.hpp>
#include <opencv2/imgproc.hpp>
#include "UnityTool.h"

class ObjectVariable
{
public:
	ObjectVariable(int i)
	{
		QFont font1 = QFont();
		font1.setBold(true);

		QFont font2 = QFont();
		font2.setPointSize(10);

		QFont font3 = QFont();
		font3.setItalic(true);

		name = new QLabel(QString("Object ") + QString::number(i + 1) + " -");
		name->setFont(font1);
		xVar = new QLabel(QString(" #O") + QString::number(i + 1) + "_X: ");
		xVar->setFont(font3);
		xValue = new QLabel();
		xValue->setFont(font2);
		yVar = new QLabel(QString(" #O") + QString::number(i + 1) + "_Y: ");
		yVar->setFont(font3);
		yValue = new QLabel();
		yValue->setFont(font2);
		aVar = new QLabel(QString(" #O") + QString::number(i + 1) + "_A: ");
		aVar->setFont(font3);
		aValue = new QLabel();
		aValue->setFont(font2);
	}

	QLabel *name;
	QLabel *xVar;
	QLabel *xValue;
	QLabel *yVar;
	QLabel *yValue;
	QLabel *aVar;
	QLabel *aValue;
};

class ObjectVariableTable : public QObject
{
	Q_OBJECT

public:
	ObjectVariableTable(QObject *parent);
	~ObjectVariableTable();

public slots:
	void DisplayDialog();
	void UpdateTable(std::vector<cv::RotatedRect> ObjectContainer);

private:
	QWidget* dialog;
	QGridLayout *gridLayout;
	QList<ObjectVariable*>* ObjectVariableWidgetList;
};
