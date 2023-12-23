using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4th
{
    public class Transform
    {
     public Transform()
        {
            Console.WriteLine("Transform 클래스 생성");
        }


        #region 생성자
        // 클래스의 인스턴스가 생성되는 시점에서 자동으로
        // 호흡되는 특수한 멤버 함수입니다.
        // Transform
        // 생성자의 경우 객체가 생성될 때 단 한 번만 호출되며,
        // 생성자는 반환형이 존재하지 않습니다.

        #endregion

        #region 가비지 컬렉터
        // 상위 클래스의 속성을 하위 클래스가 사용할 수 있도록
        // 설정해주는 기능입니다.

        // 클래스의 상속 관계에서 상위 클래스는 하위 클래스의 속성을
        // 사용할 수 없으며, 하위 클래스는 상위 클래스의 메모리를
        // 포함한 상태로 메모리의 크기가 결정됩니다.

        #endregion
    }

}
}
