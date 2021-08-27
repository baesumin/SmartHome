# SmartHome
smart home using ar, arduino, unity

- 참여자: 배수민, 박현주, 차성민
- 기간: 19.09 ~ 19.12

 - 기술스택 및 사용 툴: C#, Unity(Vuforia 라이브러리, Ardunity 라이브러리), IoT(Arduino leonardo 및 센서들, 실모형 제작까지), 3D modelling(Sketchup)

  - 내용:  

    유니티 기반으로 스마트홈을 제어하고, 사용자가 편리하게 사용할 수 있는 UI를 만들었음.
    더 나아가 슬립테크를 스마트홈에 접목시키면서 동시에 증강현실을 이용해 제어를 할 수 있게 구현함. 

    사용한 기술은 AR, IoT, 3D modeling이고, AR은 Vuforia라이브러리를 활용, IoT는 아두이노를 활용, 3D modelling은 스케치업을 활용하였고, 각 요소를 유니티 환경으로 통합하고 안드로이드 빌드를해주어 앱에서 제어가 가능하도록 설계하고 개발함.

   - 모델링 - 평면도 구상 후 Sketchup 툴을 이용하여 직접 사용할 3D모델링을 제작

   - 실모형 제작 - 우드락, 폼보드 및 센서를 이용한 실 모형 제작

   - 어플리케이션 제작 - 

    1. 유니티를 통해 UI제작, 3D 모델링 제어, 아두이노 센서 제어 등을 구현함.
    2. Sketchup을 이용해 만든 3D 모델링을 유니티로 가져오고 실제 모형에 부착되어 있는 아두이노 센서들을 제어하기 위해 ‘아두니티’ 툴을 사용

   - 인터페이스 제작  - 

    1. 홈 화면에서 모드 변경을 통해 재택모드와 외출모드로 변경
    2. 스캔을 눌러 카메라로 화면을 전환(AR 스캔)
    3. 모델을 누르면 오른쪽에 보이는 UI와 같이 3D 모델링 제어

   - 스마트 홈 제어 -

    1. 조도센서와 서보모터를 활용하여 창문 제어, 수동 및 빛의 인식을 통한 자동 조절 가능
    2. 초음파 센서를 활용하여 재택모드, 외출 모드를 구별하고 움직임이 감지되면 알림창 뜨게 함.
    3. 침대에 온습도센서, 서보모터, LED 부착 - 침대 스캔시 온습도, 조명 밝기 제어 기능 제공 및 침대 윗 부분의 기울기 조정과 알람 설정을 통해 특정 시간에 기울어지게 하는 기능 제공.


***
![그림1](https://user-images.githubusercontent.com/52240990/86191296-aa444e80-bb81-11ea-8f98-d13a7a221d43.png)

![그림2](https://user-images.githubusercontent.com/52240990/86191316-b203f300-bb81-11ea-9db8-0e935b0332e2.png)

![그림3](https://user-images.githubusercontent.com/52240990/86191320-b4fee380-bb81-11ea-94ac-5ec855fd8398.png)
![그림4](https://user-images.githubusercontent.com/52240990/86191322-b5977a00-bb81-11ea-9744-c4561822eac2.png)
![그림5](https://user-images.githubusercontent.com/52240990/86191326-b6c8a700-bb81-11ea-89b7-807c532aa91c.jpg)
![그림6](https://user-images.githubusercontent.com/52240990/86191327-b7613d80-bb81-11ea-9572-52f15dcd6cde.jpg)
![그림7](https://user-images.githubusercontent.com/52240990/86191329-b7f9d400-bb81-11ea-86a3-11c42f5156ce.jpg)
![그림8](https://user-images.githubusercontent.com/52240990/86191330-b7f9d400-bb81-11ea-9c79-120d436107ed.jpg)
![그림9](https://user-images.githubusercontent.com/52240990/86191332-b8926a80-bb81-11ea-939f-adaab5aa56fc.jpg)