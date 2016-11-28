using Xunit;
namespace LeapYear
{
  public class LeapYearTest
  {
    [Fact]
    public void IsLeapYear_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2000));
    }
    [Fact]
    public void IsLeapYear_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1999));
    }
  }
}
