import { BsGlobeAmericas } from "react-icons/bs"
import PageAccessTemplate from "../../components/pageAccess/PageAccessTemplate"
import { Container } from "semantic-ui-react"
import InboxPage from "./Messages/InboxPage"


const DashboardPage = () => {
  return (
     <Container fluid>
       <PageAccessTemplate color="#000" icon={BsGlobeAmericas} role='Dashboard'>
      </PageAccessTemplate>  
     </Container>  
  
  )
}

export default DashboardPage