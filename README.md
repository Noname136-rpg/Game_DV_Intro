# Game_DV_Intro

필수 기능
1. 캐릭터 만들기  > 구현

2. 캐릭터 이동 > 일단 완성은 되었지만 문제 발생
   
![move](https://github.com/Noname136-rpg/Game_DV_Intro/assets/71596977/fc310210-8465-4a1d-96c6-7a0c63abdbb6)

문제 : 벽과 충돌시 아래 처럼 떨림 발생

![collision Problem](https://github.com/Noname136-rpg/Game_DV_Intro/assets/71596977/b747f220-f619-412c-a0ee-8dcaa6a5c733)

문제점 발견  
예측 원인 : Player 이동을 Player의 transform을 직접 만져서 이동시킴
![image](https://github.com/Noname136-rpg/Game_DV_Intro/assets/71596977/c3ad50b5-dec4-412b-8943-95ccc6d65dcc)

위의 Unity flowchart를 보면 플레이어 이동 로직을 수행하는 Update와 OnCollision 처리가 각기 다른 시간에 발생되어서 
출동 처리 > tranform을 만져서 강제로 이동 > 벽을 조금 넘어감 > 충돌처리 (여기서 다시 뒤로 플레이어를 옮기는 듯)
위 사이클이 반복되는 것으로 예상

해결 방안 : 이동을 rigidbody에서 처리하여서 충돌처리와 이동처리가 한번에 되도록한다.

rigidbody를 이용해서 구현 (미완)
> 이동은 구현이 되었으나 키보드가 떼어졌을 때 멈추도록 구현해야함
> 키보드가 눌린 상태와 떼어진 순간을 알 수 있는 분기가 필요

3. 방 만들기 > 구현

4. 카메라 따라가기 > 구현
   
현재는 그냥 플레이어에게 Main 카메라를 상속시켜서 플레이어를 따라가게 구현
더 좋은 방법 강구가 필요함



선택 요구사항
1. 캐릭터 애니메이션 추가

![ani](https://github.com/Noname136-rpg/Game_DV_Intro/assets/71596977/3c1d97ec-59f5-4754-8cc2-0481401a319a)

각 프레임마다 이전 좌표와 비교하여 동일하다면 멈춘것으로 간주하고 animation 중단
이전 좌표와 다르다면 walking animation 실행

