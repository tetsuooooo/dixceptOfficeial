// 共通処理
import { Component, Vue} from 'vue-property-decorator';

@Component
export class methods extends Vue {
    data(){
        return{
              uploadImageUrl: '',
        }
    }
    // inputで指定した画像を画面上に表示させる
    imagePiked(file) {
             if (!this.$refs.imageValidate.validate(file)) {
                return;
            }
            if (file !== undefined && file !== null) {
                // 拡張子がない場合はrerurn
                if (file.name.lastIndexOf('.') <= 0) {
                    this.$data.uploadImageUrl = ''
                }

                const fr = new FileReader()
                fr.readAsDataURL(file)
                fr.addEventListener('load', () => {
                    this.$data.uploadImageUrl = fr.result
                })
            } else {
                this.$data.uploadImageUrl = ''
            }
    }
}