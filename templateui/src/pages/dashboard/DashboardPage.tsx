import { BsGlobeAmericas } from "react-icons/bs"
import PageAccessTemplate from "../../components/pageAccess/PageAccessTemplate"
import { Container } from "semantic-ui-react"


const DashboardPage = () => {
  return (
     <Container fluid>
       <PageAccessTemplate color="#000" icon={BsGlobeAmericas} role='Dashboard'>
        <div className="text-3xl space-y-2">
          <h1>fddfd</h1>
          <h1>fddfd</h1>
          <h1>fddfd</h1>
          <h1>fddfd</h1>
          </div>  
      </PageAccessTemplate>  
     </Container>  
  
  )
}

export default DashboardPage